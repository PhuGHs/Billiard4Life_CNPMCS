﻿using Billiard4Life_CNPMCS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Billiard4Life_CNPMCS.State.Navigator
{
    public enum TypeOfView
    {
        NhanVien,
        Kho,
        Menu,
        MenuAdmin,
        LichSuBan,
        TinhTrangBan,
        CaiDat,
        DangXuat,
        ThongKe,
        Bep
    }
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        string CurrentTitle { get; set; }
        Visibility AdminView { get; set; }
        Visibility EmployeeView { get; set; }
        ICommand SelectViewModelCommand { get; }
    }
}