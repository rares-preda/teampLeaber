using Client.TeampLeaber.ProiectColectiv.Models;
using Client.TeampLeaber.ProiectColectiv.Networking.Requests;
using Client.TeampLeaber.ProiectColectiv.Utils;
using Client.TeampLeaber.ProiectColectiv.Views;
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
        private List<ReligieModel> _religii;
        private List<TipActModel> tipuriActe;
        private List<ActModel> acte;
        private List<Models.MormantModel> mormintelibere;
       
        private DocumentForm documentForm;
        private DocumentTypeForm documentTypeForm;
        private EditDocumentTypeForm editDocumentTypeForm;
        private ReligionForm religionForm;
        private AddReligiiForm addReligiiForm;

        public MainController(MainForm mainForm)
        {
            view = mainForm;
            view.SetController(this);

            documentForm = new DocumentForm();
            documentForm.SetController(this);
            GetReligions();
            GetDecedati();
        }

        private async Task GetReligions()
        {
            Networking.Requests.GetReligiiRequest req = new Networking.Requests.GetReligiiRequest();
            _religii = await req.Run();
            
            if (view != null)
                view.SetReligionsTab1(_religii);

            if (religionForm != null)
                religionForm.SetListElements(_religii);
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
                view.GetSelectedMormantTab1() == null ? 0 : view.GetSelectedMormantTab1().Id, view.SelectedDateTab1, true, acte);

            if (!model.IsValid())
                return;
            var request = new Networking.Requests.ProgramareInmormantareRequest(model);
            bool ok = await request.Run();
            if (!ok)
                return;
            view.ClearAllDataAfterSuccess();
            MessageBox.Show(Utils.Constants.SUCCESS_MESSAGE);
        }

        internal async void ProgrameazaInmormantareFaraApartinator()
        {
            InmormantareModel model = new InmormantareModel(String.Empty, String.Empty, null, view.GetSelectedReligionTab1().Id,
               view.GetSelectedMormantLiberTab1() == null ? 0 : view.GetSelectedMormantLiberTab1().Id, view.SelectedDateTab1, false, acte);

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

        internal  void SaveDocumentCommand()
        {
            var name = documentForm.ActName;
            var id = documentForm.TipID;
            ActModel act = new ActModel(name, id, documentForm.TipName);

            if (!act.IsValid())
                return;

            if (acte == null)
                acte = new List<ActModel>();
            acte.Add(act);
            view.UpdateActeList(acte);
            documentForm.Close();
    
        }

        internal void EditReligiiCommand()
        {
            religionForm = new ReligionForm();
            religionForm.SetController(this);
            religionForm.Show();

            religionForm.SetListElements(_religii);

        }

        internal void AddReligionCommand()
        {
            addReligiiForm = new AddReligiiForm();
            addReligiiForm.SetController(this);
            addReligiiForm.CurrentReligionName = String.Empty;
            addReligiiForm.Show();

        }

        internal async void SaveReligionCommand()
        {
            var nume = addReligiiForm.CurrentReligionName;
            ReligieModel r = new ReligieModel();
            r.Denumire = nume;

            if (!r.IsValid())
                return;
            if (addReligiiForm.SelectedReligionID == 0)
            {
                var request = new Networking.Requests.PutReligionRequest(r);
                bool ok = await request.Run();
                if (ok)
                {
                    addReligiiForm.Close();
                    GetReligions();
                }
            }
            else
            {
                var request = new Networking.Requests.PostReligionRequest(r);
                r.Id = addReligiiForm.SelectedReligionID;
                bool ok = await request.Run();
                if (ok)
                {
                    addReligiiForm.Close();
                    GetReligions();
                }
            }
        }

        internal void EditSelectedReligionCommand()
        {
            addReligiiForm = new AddReligiiForm();
            addReligiiForm.SetController(this);
            addReligiiForm.CurrentReligionName = religionForm.SelectedReligie.Denumire;
            addReligiiForm.SelectedReligionID = religionForm.SelectedReligie.Id;
            addReligiiForm.Show();
        }

        internal async void DeleteSelectedReligionCommand()
        {
            var request = new Networking.Requests.DeleteReligionRequest(religionForm.SelectedReligie.Id);
            bool ok = await request.Run();
            if (ok)
            {
                await GetReligions();
                religionForm.SetCommandsAvailability();
            }
        }

        internal async void DeleteActCommand()
        {
            var id = documentTypeForm.SelectedTipAct.Id;
            var request = new Networking.Requests.DeleteTipActRequest(id);
            bool ok = await request.Run();
            if (ok)
            {
                await RefreshTipuriActe();
                documentTypeForm.SetCommandsAvailability();
            }
        }

        internal void DeleteSelectedActCommand()
        {
            var act = view.SelectedActTab1;
            if (acte.Contains(act))
                acte.Remove(act);
                documentForm.Close();
            view.UpdateActeList(acte);
            view.SetCommandsAvailabilityTab1();
        }
    

        internal async void NewDateSelected()
        {
            var date = view.SelectedDateTab1;
            if (view.GetSelectedMormantTab1() == null)
                return;
            var id = view.GetSelectedMormantTab1().Id;
            var request = new Networking.Requests.GetInmormantariByDate(date, id);
            var list = await request.Run();
            view.SetInmormantariListTab1(list);
        }

        internal async void GetMorminteLibereCommand()
        {
            var request = new Networking.Requests.GetMorminteLibereRequest();
            mormintelibere = await request.Run();
            view.PopulateMorminteLibereList(mormintelibere);
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
