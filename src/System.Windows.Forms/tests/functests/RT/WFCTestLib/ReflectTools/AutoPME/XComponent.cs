using System;
using System.ComponentModel;
using WFCTestLib.Logging;
using WFCTestLib.Util;

namespace ReflectTools.AutoPME {
    public abstract class XComponent : XMarshalByRefObject {
        public XComponent(String[] args) : base(args) { }

        protected override void InitTest(TParams p) {
            base.InitTest(p);

            // No way to raise this event without disposing the component.
            ExcludedEvents.Add("Disposed");
        }

        protected virtual ScenarioResult set_Site(TParams p, ISite value) {
            return get_Site(p);
        }
        
        protected virtual ScenarioResult get_Site(TParams p) {
            return ScenarioResult.Pass;
        }

        protected override ScenarioResult ToString(TParams p) {
            return base.ToString(p);
        }

        protected virtual ScenarioResult Dispose(TParams p) {
            return ScenarioResult.Pass;
        }
        protected virtual ScenarioResult get_Container(TParams p) {
            return ScenarioResult.Pass;
        }
    }
}