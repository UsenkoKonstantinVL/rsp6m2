using System;
using System.Collections.Generic;
using System.Text;
using rsp6m2.Manager;
namespace rsp6m2.Controls
{
    public interface IHighlight
    {
        void SetHighlight(ProjectManager prManager);
        void UnSetHighlight(ProjectManager prManager);
    }
}
