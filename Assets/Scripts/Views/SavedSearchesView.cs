using StlVault.AppModel.ViewModels;
using StlVault.Util.Collections;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable 0649

namespace StlVault.Views
{
    internal class SavedSearchesView : ContainerView<SavedSearchesModel, SavedSearchView, SavedSearchModel>
    {
        [SerializeField] private Button _addButton;
        
        protected override IReadOnlyObservableList<SavedSearchModel> Items => ViewModel.SavedSearches;

        protected override void OnViewModelBound()
        {
            base.OnViewModelBound();
            
            _addButton.Bind(ViewModel.SaveCurrentSearchCommand);
        }
    }
}