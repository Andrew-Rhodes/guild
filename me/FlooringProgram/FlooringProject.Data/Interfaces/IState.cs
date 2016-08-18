using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Models;

namespace FlooringProject.Data.Interfaces
{
    public interface IState
    {
        State GetStateName(string name);
    }
}
