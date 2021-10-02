using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Practica_EF_Api.Models.ModelsRequest;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_MVC.Models;

namespace Practica_EF_WebApi.Controllers.ControllersApiNortwind
{
    public class CustomerApiController : ApiController
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
        public IHttpActionResult InsertCustomer ([FromBody] CustomerRequest customerRequest)
        {
            if (customerRequest.Equals(null) && customerRequest.CustomerID!=null)
            {
                return BadRequest( "Los Datos estan vacios, o esta intentado crear un cliente que ya existe" );
            }
            try
            {
                Customers customerEntitie = customerRequest.MapCustomerRequestToCustomer();
                if (ModelState.IsValid)
                {
                    Random rnd = new Random();
                    int id_num = rnd.Next(1, 10);
                    string id_String = "a";
                    id_String += id_num.ToString();
                    id_String += id_num.ToString();
                    customerEntitie.CustomerID = id_String;
                    var rst = customLogic.Insert(customerEntitie);

                    return Ok<string>("Datos Ingresados");
                }
                else
                {
                    return BadRequest("Los Datos no son validos, o el id ya existe");
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
            if (customerRequest.Equals(null) || (customerRequest.CustomerID == null) || (customerRequest.CustomerID.Equals("")))
            {
                return BadRequest("Los Datos estan vacios");
            }
            try
            {
                Customers customerEntitie = customerRequest.MapCustomerRequestToCustomer();
                if (ModelState.IsValid && customLogic.Exist(customerEntitie.CustomerID)!=null)
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
                if (customLogic.Exist(custId) != null)
                {
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
                else
                {
                    return BadRequest("Los Datos no existen, o el id es nulo");
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
 
        }

    }
}


  




