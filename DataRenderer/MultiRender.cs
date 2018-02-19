using System;
using System.Linq;
using System.Collections.Generic;

namespace DataRenderer {
    public class MultiRender{

        private IDataRendererAdapter dataRendererAdapter;

        public MultiRender(IDataRendererAdapter dataRendererAdapter)
        {
            this.dataRendererAdapter = dataRendererAdapter;   
        }
        public string Show(IEnumerable<string> source){
            return dataRendererAdapter.Show(source);
        }
    }
}