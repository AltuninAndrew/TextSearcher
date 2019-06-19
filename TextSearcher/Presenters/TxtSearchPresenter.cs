using System;
using System.Threading.Tasks;
using TextSearcher.Models;
using TextSearcher.Views;

namespace TextSearcher.Presenters
{ 
    class TxtSearchPresenter
    {
        private TxtSearcher _txtSearcher = new TxtSearcher();
        private ITxtSearcher _txtSearcherView;
       
        public TxtSearchPresenter(ITxtSearcher view)
        {
            _txtSearcherView = view;
        }

        private void UpdateModel()
        {
            _txtSearcher.Pattern = _txtSearcherView.Pattern;
            _txtSearcher.PatternFileName = _txtSearcherView.PatternFileName;
            _txtSearcher.RootDirectory = _txtSearcherView.RootDirectory;   
        }

        private void UpdateView()
        {
            _txtSearcherView.CountProcessingFile = _txtSearcher.CountProcessingFile;

            if(_txtSearcher.FoundFileNames=="")
            {
                _txtSearcherView.FoundFiles = "No files found";
            }
            else
            {
                _txtSearcherView.FoundFiles = _txtSearcher.FoundFileNames;
            }
           
            _txtSearcherView.SearchStatus = _txtSearcher.SearchStatus;
        }

        private void UpdateElapsedTimeInView()
        {
            _txtSearcherView.ElapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            _txtSearcher.SpendTime.Hours, _txtSearcher.SpendTime.Minutes, _txtSearcher.SpendTime.Seconds,
            _txtSearcher.SpendTime.Milliseconds / 10);
        }

        public async Task StartSearchTxt()
        {
            UpdateView(); //get all value from searcher, before changing 
            _txtSearcherView.SearchStatus = "Running"; // crutch, need because default value is "Stopped"
            await Task.Run(() =>
            {
                UpdateModel();
                _txtSearcher.Search();   
            });

            UpdateView();
            UpdateElapsedTimeInView();
        }

        public void StopSearchTxt()
        {
            UpdateView();
            _txtSearcher.StopSearch();
            
        }

        public void PauseSearchTxt()
        {
            UpdateView();
            _txtSearcher.PauseSearch();
        }
    }
}
