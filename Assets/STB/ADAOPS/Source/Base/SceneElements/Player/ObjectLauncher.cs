using UnityEngine;
using System.Collections;

namespace STB.ADAOPS
{
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Class: ObjectLauncher
	/// # To handle object's launching from player
	/// </summary>
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	public class ObjectLauncher : MonoBehaviour
	{
		
		public DirtyObject craterCreator = null;

		// private
		GameObject objectsContainer = null;

		
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// Start
		/// # Initialise all
		/// </summary>
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		void Start ()
		{
			objectsContainer = BasicFunctions.CreateContainerIfNotExists ("_OBJECTS");
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// Update
		/// # Update the class and get mouse inputs
		/// </summary>
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		void FixedUpdate ()
		{
			DirtyObject dirtyObject = null;
		

			if (Input.GetKeyDown (KeyCode.Escape))
			{
				dirtyObject = Instantiate (craterCreator);
			}

			// if we have created a new dirty object
			if (dirtyObject)
			{
				dirtyObject.transform.position = this.transform.position + 1.5f * this.transform.forward;
				dirtyObject.GetComponent<Rigidbody> ().velocity = 30 * this.transform.forward;
				dirtyObject.transform.parent = objectsContainer.transform;
				
				Destroy (dirtyObject.gameObject, 20);
			}
		}
	}
}