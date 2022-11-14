using PractMVVM.Command;
using PractMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PractMVVM.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private GroupModel _groupModel;
        private string _info;
        public string Info
        {
            get => _info;
            set
            {
                _info = value;
                OnPropertyChanged(nameof(Info));
            }
        }

        public GroupModel GroupModel
        {
            get => _groupModel;
            set
            {
                _groupModel = value;
                OnPropertyChanged(nameof(GroupModel));
            }
        }
        public void SetInfo(object Object)
        {
            Info = GroupModel.Group + ", " + GroupModel.Deportament;
        }
        public ICommand setInfoCommand { get; }
        public MainWindowViewModel()
        {
            GroupModel = new GroupModel();
            setInfoCommand = new RelativCommand(SetInfo);
        }
    }
}
