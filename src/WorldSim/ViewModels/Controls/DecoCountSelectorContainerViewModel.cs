using Reactive.Bindings;
using SimModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSim.Util;

namespace WorldSim.ViewModels.Controls
{
    internal class DecoCountSelectorContainerViewModel : ChildViewModelBase
    {
        public ReactivePropertySlim<ObservableCollection<DecoCountSelectorViewModel>> SelectorVMs { get; set; } = new();

        public ReactivePropertySlim<string> Category { get; set; } = new();



        public DecoCountSelectorContainerViewModel(string category, IEnumerable<Deco> decos)
        {
            Category.Value = category;

            ObservableCollection<DecoCountSelectorViewModel> vms = new();
            foreach (var deco in decos)
            {
                vms.Add(new DecoCountSelectorViewModel(deco));
            }
            SelectorVMs.ChangeCollection(vms);
        }
    }
}
