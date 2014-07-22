using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace CR_ReferencesMetric
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            registerReferencesMetric();
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion
        private void registerReferencesMetric()
        {
            var ReferencesMetric = new DevExpress.CodeRush.Extensions.CodeMetricProvider(components);
            ((System.ComponentModel.ISupportInitialize)(ReferencesMetric)).BeginInit();
            ReferencesMetric.ProviderName = "ReferencesMetric"; // Should be Unique
            ReferencesMetric.DisplayName = "References";
            ReferencesMetric.GetMetricValue += ReferencesMetric_GetMetricValue;
            ((System.ComponentModel.ISupportInitialize)(ReferencesMetric)).EndInit();
        }
        private void ReferencesMetric_GetMetricValue(Object sender, DevExpress.CodeRush.Extensions.GetMetricValueEventArgs ea)
        {
            ea.Value = ea.LanguageElement.FindAllReferences().Count();
        }
        
    }
}