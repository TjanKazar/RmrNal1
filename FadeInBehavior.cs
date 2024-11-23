using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmrNal1
{
	internal class FadeInBehavior : Behavior<View>
	{
		protected override void OnAttachedTo(View view)
		{
			base.OnAttachedTo(view);
			view.Opacity = 0;
			view.FadeTo(1, 1000);
		}
	}
}
