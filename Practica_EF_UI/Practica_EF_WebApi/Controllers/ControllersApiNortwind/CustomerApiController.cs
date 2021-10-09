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
        public List<CustomerResponse> GetAll()
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

            return customersResponse;
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
            if (!ModelState.IsValid)
            {
                return BadRequest("El modelo de datos esta incorrecto");
            }
            if (customerRequest.Equals(null) && customerRequest.CustomerID!=null)
            {
                return BadRequest( "Los Datos estan vacios, o esta intentado crear un cliente que ya existe" );
            }
            try
            {
                customerRequest.setNewId();
                Customers customerEntitie = customerRequest.MapCustomerRequestToCustomer();
                customLogic.Insert(customerEntitie);
                return Ok<string>("Datos Ingresados");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        
        }

        [HttpPut]
        public IHttpActionResult Put( [FromBody] CustomerRequest customerRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("El modelo de datos esta incorrecto");
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
                        return Ok<string>("Datos editados");
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
                return Ok<string>("Datos eliminados");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}


  




