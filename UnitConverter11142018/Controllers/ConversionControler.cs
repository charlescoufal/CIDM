using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter11142018.Models;

namespace UnitConverter11142018.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the message";
            return View();
        }

        public IActionResult Converter()
        {
            return View();
        }


       [HttpPost]
        public IActionResult DoConversion(ConverterViewModel model)
        {
            switch(model.ConversionType)
            {
                case "CtoF":
                {
                    
                    model.ConvertedValue = (1.8*model.ValueToConvert) + 32;
            
                    return View(model);
                
                }

                case "FtoC":
                {
                    model.ConvertedValue = (model.ValueToConvert - 32) / 1.8;
            
                    return View(model);
                    
                }
                case "CtoK":
                {
                    
                    model.ConvertedValue = model.ValueToConvert + 273;
            
                    return View(model);
                    
                }
                case "KtoC":
                {
                    
                    model.ConvertedValue = model.ValueToConvert - 273;
            
                    return View(model);
                    
                }
                case "FtoK":
                {
                    
                    model.ConvertedValue = (model.ValueToConvert + 460) / 1.8;
            
                    return View(model);
                    
                }
                case "KtoF":
                {
                    
                    model.ConvertedValue = (model.ValueToConvert * 1.8) - 460;
            
                    return View(model);
                    
                }
                case "MeterstoFeet":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 0.3048;
            
                    return View(model);
                    
                }
                case "FeettoMeters":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 0.3048;
            
                    return View(model);
                    
                }
                case "FeettoYards":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 3;
            
                    return View(model);
                    
                }
                case "YardstoFeet":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 0.3048;
            
                    return View(model);
                    
                }
                case "YardstoMeters":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 1.0936;
            
                    return View(model);
                    
                }
                case "MeterstoYards":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 1.0936;
            
                    return View(model);
                    
                }
                case "OuncetoPound":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 16;
            
                    return View(model);
                    
                }
                case "PoundtoOunce":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 16;
            
                    return View(model);
                    
                }
                case "PoundtoGram":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 454.6;
            
                    return View(model);
                    
                }
                case "GramtoPound":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 454.6;
            
                    return View(model);
                    
                }
                case "GramtoOunce":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 28.3;
            
                    return View(model);
                    
                }
                case "OuncetoGram":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 28.3;
            
                    return View(model);
                    
                }
                case "GramtoKilogram":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 1000;
            
                    return View(model);
                    
                }
                case "KilogramtoGram":
                {
                   
                    model.ConvertedValue = model.ValueToConvert * 1000;
            
                    return View(model);
                    
                }
                case "KilogramtoPound":
                {
                    
                    model.ConvertedValue = model.ValueToConvert / 0.454;
            
                    return View(model);
                    
                }
                case "PoundtoKilogram":
                {
                    
                    model.ConvertedValue = model.ValueToConvert * 0.454;
            
                    return View(model);
                    
                }
                
                default:
                {
                    return View(model);
                    
                }
            //conversion happens here

        }       

        
    }
    }
}
