using org.drools;
using org.drools.compiler;
using org.drools.rule;
using System.IO;
using System.Reflection;

namespace SEP.Service.Helpers
{
    public static class  RuleBaseHelper
    {
        public static WorkingMemory GetWorkingMemoryForRule(string ruleFileName)
        {
            Stream stream = Assembly.GetAssembly(typeof(RuleBaseHelper)).GetManifestResourceStream("SEP.Service.Rules." + ruleFileName + ".drl");
            PackageBuilder builder = new PackageBuilder();
            builder.addPackageFromDrl("", DroolsDotnetUtil.getJavaStringReaderFromSystemStream(stream));

            Package pkg = builder.getPackage();
            RuleBase ruleBase = RuleBaseFactory.newRuleBase();
            ruleBase.addPackage(pkg);
            WorkingMemory workingMemory = ruleBase.newWorkingMemory();

            return workingMemory;
        }
    }
}