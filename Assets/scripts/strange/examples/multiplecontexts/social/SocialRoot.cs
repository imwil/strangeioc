/// The Root is the entry point to a strange-enabled Unity3D app.
/// ===============
/// 
/// Attach this MonoBehaviour to a GameObject at the top of a scene in social.unity.
/// 
/// Social mocks a social component within your app, for example checking your high-score against
/// that of your Facebook friends.

using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace strange.examples.multiplecontexts.social
{
	public class SocialRoot : ContextView
	{
	
		void Awake()
		{
			//Instantiate the context, passing it this instance and a 'true' for autoStartup.
			context = new SocialContext(this, true);
			context.Start ();
		}
	}
}
