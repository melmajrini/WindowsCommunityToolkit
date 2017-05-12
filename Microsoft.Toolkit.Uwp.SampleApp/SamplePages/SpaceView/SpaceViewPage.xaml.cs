﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpaceViewPage : Page
    {
        ObservableCollection<DeviceItem> Devices = new ObservableCollection<DeviceItem>();
        Random random = new Random();

        public SpaceViewPage()
        {
            this.InitializeComponent();

            Devices.Add(new DeviceItem() { Distance = 0.1, Label = "My Phone", Symbol = Symbol.CellPhone });
        }

        private void AddDeviceClick(object sender, RoutedEventArgs e)
        {
            Devices.Add(new DeviceItem() { Distance = random.Next(1, 10) / 10f, Label = "My Phone", Symbol = Symbol.CellPhone });
        }

        private void itemClicked(object sender, SpaceViewItemClickedEventArgs e)
        {
            Devices.Remove(e.Item as DeviceItem);
        }
    }

    public class DeviceItem : SpaceViewItem
    {
        public Symbol Symbol { get; set; }
    }
}
