using ESAPIX.Interfaces;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Common;
using VMS.TPS.Common.Model.API;
using Prism.Commands;
using System.Collections.ObjectModel;

namespace Schmidt_PlanChecker.ViewModels
{
    public class MainViewModel : BindableBase
    {
        AppComThread VMS = AppComThread.Instance;

        public MainViewModel()
        {

            ////Example data bind
            //OnPlanChanged(VMS.GetValue(sc => sc.PlanSetup));
            ////Handle plan changes
            //VMS.Execute(sc =>
            //{
            //    sc.PlanSetupChanged += OnPlanChanged;
            //});
        }
        public DelegateCommand EvaluateCommand { get; set; }
        public ObservableCollection<PlanConstraint> Constraints { get; private set; } = new ObservableCollection<PlanConstraint>();
    }
}
