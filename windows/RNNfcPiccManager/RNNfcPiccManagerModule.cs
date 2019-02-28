using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Nfc.Picc.Manager.RNNfcPiccManager
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNfcPiccManagerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNfcPiccManagerModule"/>.
        /// </summary>
        internal RNNfcPiccManagerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNfcPiccManager";
            }
        }
    }
}
