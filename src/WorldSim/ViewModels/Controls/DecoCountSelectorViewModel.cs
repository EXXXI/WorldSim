using Reactive.Bindings;
using SimModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSim.ViewModels.Controls
{
    internal class DecoCountSelectorViewModel : ChildViewModelBase
    {
        public ReactivePropertySlim<string> DispName { get; set; } = new();

        public ReactivePropertySlim<int> DecoCount { get; set; } = new();

        public ReactivePropertySlim<ObservableCollection<int>> DecoCountList { get; set; } = new();

        private Equipment BaseDeco { get; set; }

        public DecoCountSelectorViewModel(Equipment deco)
        {
            BaseDeco = deco;
            DispName.Value = deco.DispName;
            DecoCount.Value = deco.DecoCount;
            DecoCountList.Value = new() { 0, 1, 2, 3, 4, 5, 6, 7};

            DecoCount.Subscribe(_ => SaveDecoCount());
        }

        private void SaveDecoCount()
        {
            Simulator.SaveDecoCount(BaseDeco, DecoCount.Value);
        }
    }
}
