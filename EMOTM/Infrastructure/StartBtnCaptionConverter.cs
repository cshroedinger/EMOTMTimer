﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace EMOTM.Infrastructure
{
	class StartBtnCaptionConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string caption = "Start";
			// value is TimerState
			// targetType is string
			TimerState ts = (TimerState) value;
			switch (ts)
			{
				case TimerState.Started:
					break;
				case TimerState.Stopped:
					caption = "Start";
					break;
				case TimerState.Paused:
					caption = "Continue";
					break;
				default:
					break;
			}
			return caption;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}