using Amazon.JSII.Runtime.Deputy;
using Amazon.JSII.Tests.CalculatorNamespace.BaseOfBaseNamespace;
using System;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    [JsiiByValue]
    public class ImplictBaseOfBase : IImplictBaseOfBase
    {
        [JsiiProperty(name: "goo", typeJson: "{\"primitive\":\"date\"}", isOverride: true)]
        public DateTime Goo
        {
            get;
            set;
        }

        [JsiiProperty(name: "bar", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bar
        {
            get;
            set;
        }

        [JsiiProperty(name: "foo", typeJson: "{\"fqn\":\"@scope/jsii-calc-base-of-base.Very\"}", isOverride: true)]
        public Very Foo
        {
            get;
            set;
        }
    }
}