using System.Linq;
using System.Collections.Generic;
public interface IDataRendererAdapter {
    string Show(IEnumerable<string> source);
}