// OculusVR System|SDK_OculusVR|001
namespace VRTK
{
#if VRTK_SDK_OCULUSVR
    /// <summary>
    /// The OculusVR System SDK script provides a bridge to the OculusVR SDK.
    /// </summary>
    public class SDK_OculusVRSystem : SDK_BaseSystem
    {
        /// <summary>
        /// The IsDisplayOnDesktop method returns true if the display is extending the desktop.
        /// </summary>
        /// <returns>Returns true if the display is extending the desktop</returns>
        public override bool IsDisplayOnDesktop()
        {
            return false;
        }

        /// <summary>
        /// The ShouldAppRenderWithLowResources method is used to determine if the Unity app should use low resource mode. Typically true when the dashboard is showing.
        /// </summary>
        /// <returns>Returns true if the Unity app should render with low resources.</returns>
        public override bool ShouldAppRenderWithLowResources()
        {
            return false;
        }

        /// <summary>
        /// The ForceInterleavedReprojectionOn method determines whether Interleaved Reprojection should be forced on or off.
        /// </summary>
        /// <param name="force">If true then Interleaved Reprojection will be forced on, if false it will not be forced on.</param>
        public override void ForceInterleavedReprojectionOn(bool force)
        {
        }
    }
#else
    public class SDK_OculusVRSystem : SDK_FallbackSystem
    {
    }
#endif
}