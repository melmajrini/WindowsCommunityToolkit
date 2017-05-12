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

using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// A class that can be used to provide data context for <see cref="SpaceView"></see> items by providing distance and diameter values
    /// </summary>
    public class SpaceViewItem : DependencyObject
    {
        /// <summary>
        /// Gets or sets a value indicating the distance from the center.
        /// Expected value betweeen 0 and 1
        /// </summary>
        public double Distance
        {
            get { return (double)GetValue(DistanceProperty); }
            set { SetValue(DistanceProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DistanceProperty"/> property
        /// </summary>
        public static readonly DependencyProperty DistanceProperty =
            DependencyProperty.Register("Distance", typeof(double), typeof(SpaceViewItem), new PropertyMetadata(0.5));

        /// <summary>
        /// Gets or sets a value indicating the name of the item.
        /// Used for <see cref="AutomationProperties"/>
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="LabelProperty"/> property
        /// </summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(SpaceViewItem), new PropertyMetadata("SpaceViewItem"));

        /// <summary>
        /// Gets or sets a value indicating the diameter of the item.
        /// Expected value betweeen 0 and 1
        /// </summary>
        public double Diameter
        {
            get { return (double)GetValue(DiameterProperty); }
            set { SetValue(DiameterProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DiameterProperty"/> property
        /// </summary>
        public static readonly DependencyProperty DiameterProperty =
            DependencyProperty.Register("Diameter", typeof(double), typeof(SpaceViewItem), new PropertyMetadata(-1d));

        /// <summary>
        /// Gets or sets a value indicating the image of the item.
        /// </summary>
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="ImageProperty"/> property
        /// </summary>
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(SpaceViewItem), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets a value of an object that can be used to store model data.
        /// </summary>
        public object Item
        {
            get { return (object)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="ItemProperty"/> property
        /// </summary>
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", typeof(object), typeof(SpaceViewItem), new PropertyMetadata(null));


    }
}
