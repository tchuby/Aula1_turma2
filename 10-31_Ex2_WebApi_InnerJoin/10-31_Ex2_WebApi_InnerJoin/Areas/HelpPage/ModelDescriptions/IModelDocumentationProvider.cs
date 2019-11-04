using System;
using System.Reflection;

namespace _10_31_Ex2_WebApi_InnerJoin.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}