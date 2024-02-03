using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CastManager : ICastService
    {
        ICastDal _castDal;

        public CastManager(ICastDal castDal)
        {
            _castDal = castDal;
        }
    }
}
