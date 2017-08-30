using System.Collections;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine;

namespace Takohi
{
	public class ButtonExtension : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
	#region PointerDown
		[Serializable]
		public class ClickDownEvent : UnityEvent
		{
		}

		// Event delegates triggered on down.
		[FormerlySerializedAs("onDown")]
		[SerializeField]
		private ClickDownEvent
			m_OnDown = new ClickDownEvent ();

		public ClickDownEvent onDown {
			get { return m_OnDown; }
			set { m_OnDown = value; }
		}

		// Trigger all registered callbacks.
		public virtual void OnPointerDown (PointerEventData eventData)
		{
			m_OnDown.Invoke ();
		}
	#endregion

	#region PointerUp
		[Serializable]
		public class ClickUpEvent : UnityEvent
		{
		}

		// Event delegates triggered on down.
		[FormerlySerializedAs("onUp")]
		[SerializeField]
		private ClickUpEvent
			m_OnUp = new ClickUpEvent ();

		public ClickUpEvent onUp {
			get { return m_OnUp; }
			set { m_OnUp = value; }
		}

		public virtual void OnPointerUp (PointerEventData eventData)
		{
			m_OnUp.Invoke ();
		}
	#endregion
	}
}
