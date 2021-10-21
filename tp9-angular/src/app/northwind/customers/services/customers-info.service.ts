import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Customers } from "../models/customers";
import { Observable, Observer, Subject } from "rxjs";
import { environment } from "src/environments/environment";
import { ServiceNorthwind } from "./northwind.service";
//duda

@Injectable({
    providedIn:'root'
})

export class ServiceInfoCustomers{

   
    customers: Array<Customers>=[];
    private customers$ = new Subject<Array<Customers>>();
    

    constructor(private http:HttpClient, public _serviceNorthwind:ServiceNorthwind){
        this.setAllCustomers();

    }

    
    setAllCustomers(){
        this._serviceNorthwind.GetAll().subscribe(
          res=>{
            if(res!=null){
                this.customers=res;
                this.customers$.next(this.customers);
            }
          },
          err => {
            alert(`Oops!!, Hubo un error en la conexion para traer los datos: Status error: ${err.status}, Mensaje: ${err.statusText}`)
          })
      }

    getAllCustomers$():Observable<Array<Customers>>{
        console.log("", this.customers$)
        return this.customers$.asObservable();
    }
}
