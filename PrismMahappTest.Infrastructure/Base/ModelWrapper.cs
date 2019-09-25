using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahappTest.Infrastructure.Base
{
    public class ModelWrapper<T> : BindableBase
    {
        public T Model { get; }
        public ModelWrapper(T model)
        {
            Model = model;
        }

        protected virtual TValue GetValue<TValue>([CallerMemberName] string propertyName = null)
        {
            return (TValue)typeof(T).GetProperty(propertyName).GetValue(Model);
        }
        protected virtual void SetValue<TValue>(TValue value,
            [CallerMemberName] string propertyName = null)
        {
            typeof(T).GetProperty(propertyName).SetValue(Model, value);
            RaisePropertyChanged(propertyName);
        }
    }
}
