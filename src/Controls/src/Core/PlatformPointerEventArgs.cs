﻿using System;
namespace Microsoft.Maui.Controls;

public class PlatformPointerEventArgs
{
#if IOS || MACCATALYST
	public UIKit.UIView Sender { get; }
	public UIKit.UIGestureRecognizer GestureRecognizer { get; }

	internal PlatformPointerEventArgs(UIKit.UIView sender, UIKit.UIGestureRecognizer gestureRecognizer)
	{
		Sender = sender;
		GestureRecognizer = gestureRecognizer;
	}

#elif ANDROID
	public Android.Views.View Sender { get; }
	public Android.Views.MotionEvent MotionEvent { get; }

	internal PlatformPointerEventArgs(Android.Views.View sender, Android.Views.MotionEvent motionEvent)
	{
		Sender = sender;
		MotionEvent = motionEvent;
	}

#elif WINDOWS
	public Microsoft.UI.Xaml.FrameworkElement Sender { get; }
	public Microsoft.UI.Xaml.RoutedEventArgs RoutedEventArgs { get; }

	internal PlatformPointerEventArgs(Microsoft.UI.Xaml.FrameworkElement sender, Microsoft.UI.Xaml.RoutedEventArgs routedEventArgs)
	{
		Sender = sender;
		RoutedEventArgs = routedEventArgs;
	}

#else
	internal PlatformPointerEventArgs()
	{
	}
#endif
}
