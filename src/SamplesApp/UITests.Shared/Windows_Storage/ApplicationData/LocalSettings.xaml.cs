﻿using System;
using System.Collections.Generic;
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
using Windows.Storage;

using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_Storage_ApplicationData
{
	[SampleControlInfo("Windows.Storage.ApplicationData", "LocalSettings")]
	public sealed partial class LocalSettings : Page
	{
		private const string key = nameof(key);

		public LocalSettings()
		{
			this.InitializeComponent();

			_containerName.Text = $"ApplicationDataContainerName='{ApplicationData.Current.LocalSettings.Name}'";
		}

		public void Clear(object sender, TappedRoutedEventArgs e)
		{
			ApplicationData.Current.LocalSettings.Values.Clear();
			Count();
		}

		public void Add(object sender, TappedRoutedEventArgs e)
		{
			ApplicationData.Current.LocalSettings.Values.Add(key, "value");
			Count();
		}

		public void Contains(object sender, TappedRoutedEventArgs e) => _output.Text = $"Key Exists='{ApplicationData.Current.LocalSettings.Values.ContainsKey(key).ToString()}'";

		public void Count() => _output.Text = $"Count='{ApplicationData.Current.LocalSettings.Values.Count.ToString()}'";
		public void Remove(object sender, TappedRoutedEventArgs e)
		{
			ApplicationData.Current.LocalSettings.Values.Remove(key);
			Count();
		}
	}
}
