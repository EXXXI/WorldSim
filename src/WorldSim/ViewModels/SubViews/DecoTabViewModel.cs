using Reactive.Bindings;
using SimModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldSim.Util;
using WorldSim.ViewModels.Controls;

namespace WorldSim.ViewModels.SubViews
{
    internal class DecoTabViewModel : ChildViewModelBase
    {
        public ReactivePropertySlim<ObservableCollection<DecoCountSelectorViewModel>> Decos { get; set; } = new();

        public DecoTabViewModel()
        {
            ObservableCollection<DecoCountSelectorViewModel> decos = new();
            foreach (var deco in Masters.Decos)
            {
                decos.Add(new DecoCountSelectorViewModel(deco));
            }
            Decos.ChangeCollection(decos);
        }
    }
}
