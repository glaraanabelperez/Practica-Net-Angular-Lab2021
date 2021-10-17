using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using Practica_EF_Api.Models.ModelsRequest;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_MVC.Models;

namespace Practica_EF_WebApi.Controllers.ControllersApiNortwind
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CustomerApiController : ApiController,IABMControllers<CustomerRequest>
    {
        public CustomersLogic customLogic = new CustomersLogic();

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                List<CustomerResponse> customersResponse;
                var cust = customLogic.GetAll();

                customersResponse = cust.Select(c => new CustomerResponse
                {
                    CustomerID = c.CustomerID,
                    ContactName = c.ContactName,
                    CompanyName = c.CompanyName,
                    Country = c.Country

                }).ToList();

                return  Ok(customersResponse);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        [HttpGet]
        public IHttpActionResult  Get(string custId)
        {
            try
            {
                CustomerResponse customerResponse = (customLogic.GetById(custId)).MapCustomerToCustomerResponse();
                if (customerResponse == null)
                {
                    return NotFound();
                }
                return Ok(customerResponse);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }

        [HttpPost]
        public IHttpActionResult Insert([FromBody] CustomerRequest customerRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    customerRequest.setNewId();
                    Customers customerEntitie = customerRequest.MapCustomerRequestToCustomer();
                    customLogic.Insert(customerEntitie);

                    return Ok<string>("OK");
                }
                else
                {
                    return BadRequest("El modelo de datos esta incorrecto");
                }

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        
        }

        [HttpPut]
        public IHttpActionResult Put( [FromBody] CustomerRequest customerRequest)
        {       
            if (customerRequest == null || !ModelState.IsValid)
            {
                return BadRequest("El modelo de datos esta incorrecto o vacio");
            }
            try
            {
                if (customerRequest.Equals(null) || (customerRequest.CustomerID == null) || (customerRequest.CustomerID.Equals("")))
                {
                    return BadRequest("Los Datos estan vacios");
                }

                Customers customerEntitie = customerRequest.MapCustomerRequestToCustomer();
                if (customLogic.Exist(customerEntitie.CustomerID)!=null)
                {
                    try
                    {
                        customLogic.Update(customerEntitie);
                        return Ok<string>("OK");
                    }
                    catch (Exception ex)
                    {
                        return InternalServerError(ex);
                    }
                }
                else
                {
                    return BadRequest("Los Datos no son validos, o el id es nulo");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(string custId)
        {
            if (custId ==null)
            {
                return BadRequest("Los Datos estan vacios");
            }
 
            try
            {
                customLogic.Delete(custId);
                return Ok<string>("OK");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}


  




