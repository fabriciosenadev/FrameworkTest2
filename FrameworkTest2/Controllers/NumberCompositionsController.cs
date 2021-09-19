using FrameworkTest2.Models;
using FrameworkTest2.Models.DTOs;
using FrameworkTest2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkTest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberCompositionsController : ControllerBase
    {
        private readonly NumberCompositionService _numberCompositionService;

        public NumberCompositionsController(NumberCompositionService numberCompositionService)
        {
            _numberCompositionService = numberCompositionService;
        }

        [HttpPost]
        public ActionResult<DTONumberComposition> CalculateNumberComposition(int number)
        {
            var compostion = _numberCompositionService.CalculateNumberComposition(number);
            return GetDTOFromModel(compostion);
        }

        private DTONumberComposition GetDTOFromModel(NumberComposition composition)
        {
            DTONumberComposition dtoComposition = GetNewDTONumberCompsition();
            dtoComposition.Number = composition.Number;
            dtoComposition.Denominators = composition.OutputDenominators;
            dtoComposition.PrimeNumbers = composition.OutputPrimeNumbers;
            return dtoComposition;
        }

        private DTONumberComposition GetNewDTONumberCompsition() => new DTONumberComposition();
    }
}
