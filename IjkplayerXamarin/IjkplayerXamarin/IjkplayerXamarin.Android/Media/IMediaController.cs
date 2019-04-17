﻿/*
 * Copyright (C) 2015 Zhang Rui <bbcallen@gmail.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Android.Views;
using Android.Widget;

namespace IjkplayerXamarin.Droid
{
	 

	public interface IMediaController
	{
        void Hide();

        bool IsShowing { get; }

        void SetAnchorView(View view);

        bool Enabled { get; set; }

        void SetMediaPlayer(MediaController.IMediaPlayerControl player);

        void Show(int timeout);

        void Show();

        //----------
        // Extends
        //----------
        void ShowOnce(View view);
    }

}