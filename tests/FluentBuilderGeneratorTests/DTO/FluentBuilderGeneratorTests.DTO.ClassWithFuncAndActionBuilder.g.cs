//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using FluentBuilderGeneratorTests.FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilderGeneratorTests.DTO
{
    public partial class ClassWithFuncAndActionBuilder : Builder<FluentBuilderGeneratorTests.DTO.ClassWithFuncAndAction>
    {
        private bool _func1IsSet;
        private Lazy<System.Func<int, string>> _func1 = new Lazy<System.Func<int, string>>(() => new System.Func<int, string>((_) => string.Empty));
        public ClassWithFuncAndActionBuilder WithFunc1(System.Func<int, string> value) => WithFunc1(() => value);
        public ClassWithFuncAndActionBuilder WithFunc1(Func<System.Func<int, string>> func)
        {
            _func1 = new Lazy<System.Func<int, string>>(func);
            _func1IsSet = true;
            return this;
        }
        public ClassWithFuncAndActionBuilder WithoutFunc1()
        {
            WithFunc1(() => new System.Func<int, string>((_) => string.Empty));
            _func1IsSet = false;
            return this;
        }

        private bool _func2IsSet;
        private Lazy<System.Func<int, bool, string>> _func2 = new Lazy<System.Func<int, bool, string>>(() => new System.Func<int, bool, string>((_, _) => string.Empty));
        public ClassWithFuncAndActionBuilder WithFunc2(System.Func<int, bool, string> value) => WithFunc2(() => value);
        public ClassWithFuncAndActionBuilder WithFunc2(Func<System.Func<int, bool, string>> func)
        {
            _func2 = new Lazy<System.Func<int, bool, string>>(func);
            _func2IsSet = true;
            return this;
        }
        public ClassWithFuncAndActionBuilder WithoutFunc2()
        {
            WithFunc2(() => new System.Func<int, bool, string>((_, _) => string.Empty));
            _func2IsSet = false;
            return this;
        }

        private bool _funcNullIsSet;
        private Lazy<System.Func<int?, bool?, string?>> _funcNull = new Lazy<System.Func<int?, bool?, string?>>(() => new System.Func<int?, bool?, string?>((_, _) => default(string?)));
        public ClassWithFuncAndActionBuilder WithFuncNull(System.Func<int?, bool?, string?> value) => WithFuncNull(() => value);
        public ClassWithFuncAndActionBuilder WithFuncNull(Func<System.Func<int?, bool?, string?>> func)
        {
            _funcNull = new Lazy<System.Func<int?, bool?, string?>>(func);
            _funcNullIsSet = true;
            return this;
        }
        public ClassWithFuncAndActionBuilder WithoutFuncNull()
        {
            WithFuncNull(() => new System.Func<int?, bool?, string?>((_, _) => default(string?)));
            _funcNullIsSet = false;
            return this;
        }

        private bool _actionIsSet;
        private Lazy<System.Action<int>> _action = new Lazy<System.Action<int>>(() => new System.Action<int>((_) => { }));
        public ClassWithFuncAndActionBuilder WithAction(System.Action<int> value) => WithAction(() => value);
        public ClassWithFuncAndActionBuilder WithAction(Func<System.Action<int>> func)
        {
            _action = new Lazy<System.Action<int>>(func);
            _actionIsSet = true;
            return this;
        }
        public ClassWithFuncAndActionBuilder WithoutAction()
        {
            WithAction(() => new System.Action<int>((_) => { }));
            _actionIsSet = false;
            return this;
        }


        public override ClassWithFuncAndAction Build(bool useObjectInitializer = true)
        {
            if (Object?.IsValueCreated != true)
            {
                Object = new Lazy<ClassWithFuncAndAction>(() =>
                {
                    ClassWithFuncAndAction instance;
                    if (useObjectInitializer)
                    {
                        instance = new ClassWithFuncAndAction
                        {
                            Func1 = _func1.Value,
                            Func2 = _func2.Value,
                            FuncNull = _funcNull.Value,
                            Action = _action.Value
                        };
                        return instance;
                    }

                    instance = new ClassWithFuncAndAction();
                    if (_func1IsSet) { instance.Func1 = _func1.Value; }
                    if (_func2IsSet) { instance.Func2 = _func2.Value; }
                    if (_funcNullIsSet) { instance.FuncNull = _funcNull.Value; }
                    if (_actionIsSet) { instance.Action = _action.Value; }
                    return instance;
                });
            }

            PostBuild(Object.Value);

            return Object.Value;
        }

        public static ClassWithFuncAndAction Default() => new ClassWithFuncAndAction();

    }
}
#nullable disable