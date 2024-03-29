using UnityEngine;

namespace MochaMoth.SceneObject.SceneReferences.Implementations
{
	public partial class SceneReference : ISceneReference
	{
		[SerializeField] string _scenePath = string.Empty;

#if !UNITY_EDITOR
		public string GetScenePath(Object sceneAsset) => _scenePath;
		public bool IsValidSceneAsset(Object sceneAsset) => true;
		
		public void SetScenePath(string value) { }
		public void OnBeforeSerialize(Object sceneAsset) { }
		public void OnAfterDeserialize(Object sceneAsset) { }
#endif
	}
}
