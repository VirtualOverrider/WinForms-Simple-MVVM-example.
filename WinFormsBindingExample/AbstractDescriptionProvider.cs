using System;
using System.ComponentModel;
namespace WinFormsBindingExample
{
    /// <summary>
    /// Provides backward-compatability for 'older' versions of Visual studio that don't properly
    /// infer designer context when using an abstract base.
    /// 
    /// <para>Based on example written by user P.W. on StackOverflow.com: 
    /// https://stackoverflow.com/questions/1620847/how-can-i-get-visual-studio-2008-windows-forms-designer-to-render-a-form-that-im/2406058#2406058
    /// </para>
    /// </summary>
    public class AbstractDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
            public AbstractDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(TAbstract)))
            {
            }

            public override Type GetReflectionType(Type objectType, object instance)
            {
                if (objectType.FullName == typeof(TAbstract).FullName)
                {
                    return typeof(TBase);
                }
                    
                return base.GetReflectionType(objectType, instance);
            }

            public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
            {
                if (objectType.FullName == typeof(TAbstract).FullName)
                {
                    objectType = typeof(TBase);
                }
                    

                return base.CreateInstance(provider, objectType, argTypes, args);
            }
        }
    }

