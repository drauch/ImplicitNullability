﻿using System;
using JetBrains.Annotations;

namespace ImplicitNullability.Sample.ExternalCode
{
    public static class External
    {
        public delegate void SomeDelegate(string a);

        public delegate void SomeNotNullDelegate([NotNull] string a);

        public class Class
        {
            public virtual string this[string a]
            {
                get { return null; }
            }

            public virtual void Method(string a)
            {
            }
        }

        public interface IInterfaceWithMethod<in T>
        {
            void Method(T a);
        }

        public interface IInterfaceWithCanBeNullMethod
        {
            void Method([CanBeNull] string a);
        }

        public interface IInterfaceWithNotNullMethod
        {
            void Method([NotNull] string a);
        }

        public interface IInterfaceWithRefAndOutParameterMethod
        {
            void Method(ref string refParam, out string outParam);
        }
    }
}