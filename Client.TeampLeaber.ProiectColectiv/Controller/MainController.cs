using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Networking.Requests;
using Client.TeampLeaber.ProiectColectiv.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.TeampLeaber.ProiectColectiv.Controller
{
    public class MainController
    {
        private MainForm view;
        private string _selectedMormantId;
        private List<ReligieModel> _religii;
        private List<TipActModel> tipuriActe;
        private List<ActeModel> acte;

        private DocumentForm documentForm;
        private DocumentTypeForm documentTypeForm;
        private EditDocumentTypeForm editDocumentTypeForm;

        public MainController(MainForm mainForm)
        {
            view = mainForm;
            view.SetController(this);

            documentForm = new DocumentForm();
            documentForm.SetController(this);
            GetReligions();
            GetDecedati();
        }

        private async void GetReligions()
        {
            Networking.Requests.ReligiiRequest req = new Networking.Requests.ReligiiRequest();
            _religii = await req.Run();
            view.SetReligionsTab1(_religii);
        }


        internal async void CautaConcesionarCommand()
        {
            if (String.IsNullOrEmpty(view.ConcsCnpTab1))
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Utils.Constants.ErrorMessages.NO_CNP_CONCESIONAR);
                return;
            }
            view.ClearDateConcesionarDataTab1();

            var request = new Networking.Requests.MorminteByConcesionar(view.ConcsCnpTab1);
            var value = await request.Run();
            if (value == null)
            {
                ErrorHandling.ErrorHandling.Instance.HandleError(Constants.ErrorMessages.NO_INSTANCES_MORMINTE_CONCESIONAR);
                return;
            }
            view.ConcsNumeTab1 = value.Nume;
            view.ConcsPrenumeTab1 = value.Prenume;
            view.UpdateMorminteTab1(value.Morminte);

        }

        internal async void ProgrameazaInmormantare()
        {
            InmormantareModel model = new InmormantareModel(view.DecedatNumeTab1, view.DecedatPrenumeTab1, view.DecedatCNPTab1, view.GetSelectedReligionTab1().Id,
                view.GetSelectedMormantTab1() == null ? 0 : view.GetSelectedMormantTab1().Id, view.SelectedDateTab1, acte);

            if (!model.IsValid())
                return;
            var request = new Networking.Requests.ProgramareInmormantareRequest(model);
            bool ok = await request.Run();
            if (!ok)
                return;
            MessageBox.Show(Utils.Constants.SUCCESS_MESSAGE);
        }

        internal async void ShowActeForm()
        {
            documentForm = new DocumentForm();
            documentForm.SetController(this);
            documentForm.Show();

            await RefreshTipuriActe();

        }

        private async Task RefreshTipuriActe()
        {
            var request = new GetTipActeRequest();
            tipuriActe = await request.Run();

            if (documentForm != null)
                documentForm.ShowTipuriActeInList(tipuriActe);
            if (documentTypeForm != null)
                documentTypeForm.AddTypeList(this.tipuriActe);

        }

        internal void AdaugaActeCommand()
        {
            documentTypeForm = new DocumentTypeForm();
            documentTypeForm.SetController(this);
            documentTypeForm.Show();


            documentTypeForm.AddTypeList(this.tipuriActe);
            // var request = new 
        }

        internal void AddDocumentTypeCommand()
        {
            editDocumentTypeForm = new EditDocumentTypeForm();
            editDocumentTypeForm.SetController(this);
            editDocumentTypeForm.Show();
            editDocumentTypeForm.SelectedTipActID = 0;

        }

        internal void UpdateActeCommand()
        {
            editDocumentTypeForm = new EditDocumentTypeForm();
            editDocumentTypeForm.SetController(this);
            editDocumentTypeForm.Show();
            editDocumentTypeForm.SelectedTipActID = documentTypeForm.SelectedTipAct.Id;
            editDocumentTypeForm.DocumentTypeActName = documentTypeForm.SelectedTipAct.Denumire;
        }

        internal async void SaveDocumentType()
        {
            var name = editDocumentTypeForm.DocumentTypeActName;
            var tipAct = new TipActModel(name);

            if (!tipAct.IsValid())
                return;
            tipAct.Id = editDocumentTypeForm.SelectedTipActID;
            bool ok;
            if (editDocumentTypeForm.SelectedTipActID == 0)
            {
                var request = new Networking.Requests.AddDocumentTypeRequest(tipAct);
                ok = await request.Run();

            }
            else
            {
                var request = new Networking.Requests.UpdateDocumentTypeRequest(tipAct);
                ok = await request.Run();
            }


            if (ok)
            {
                await RefreshTipuriActe();
                editDocumentTypeForm.Close();
            }

        }


        internal async void OnClosingDocumentTypeFormEvent()
        {
            await RefreshTipuriActe();
        }

        internal async void SaveDocumentCommand()
        {
            var name = documentForm.ActName;
            var id = documentForm.TipID;
            ActeModel act = new ActeModel(name, id);

            if (!act.IsValid())
                return;

            var request = new Networking.Requests.AddDocumentRequest(act);
            bool ok = await request.Run();

            if (ok)
            {
                if (acte == null)
                    acte = new List<ActeModel>();
                acte.Add(act);

                view.UpdateActeList(acte);

                documentForm.Close();
            }

        }

        internal async void GetDecedati()
        {
            var requestDecedatiCuApartinator = new Networking.Requests.DecedatiCuApartinatorRequest();
            List<DecedatCuApartinatorModel> decedatiCuApartinator = await requestDecedatiCuApartinator.Run();
            view.SetDecedatiCuApartinator(decedatiCuApartinator);

            var requestDecedatiFaraApartinator = new Networking.Requests.DecedatiFaraApartinatorRequest();
            List<DecedatFaraApartinatorModel> decedatiFaraApartinator = await requestDecedatiFaraApartinator.Run();
            view.SetDecedatiFaraApartinator(decedatiFaraApartinator);
        }

    }
}
