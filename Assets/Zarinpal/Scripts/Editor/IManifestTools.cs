using System;
namespace ZarinpalIAB
{
		public interface IManifestTools
    {
#if UNITY_EDITOR
			void UpdateManifest();
			void ClearManifest();
#endif
		}
}

