import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Customers } from "../models/customers";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
//duda

@Injectable({
    providedIn:'root'
})

export class ServiceNorthwind{

    endpoint: string='CustomerApi';

    constructor(private http:HttpClient){}

    Delete(custId:string):Observable<any>{

        let idString:string='?custId=' + custId;
        let url=environment.northwindApi + this.endpoint + idString;
        let rsta=this.http.delete<any>(url);
        return rsta;
    }


    GetAll(): Observable<Array<Customers>>{

        let url=environment.northwindApi + this.endpoint;
        return this.http.get<Array<Customers>>(url);
    }

    GetById(custId:string):Observable<any>{

        let idString:string='?custId=' + custId;
        let url=environment.northwindApi + this.endpoint + idString;
        return this.http.get<any>(url);
    }

    Put(customer:Customers):Observable<any>{
        let url=environment.northwindApi + this.endpoint;
        let rsta=this.http.put<Array<Customers>>(url, customer);
        console.log("rsta", rsta)
        return rsta;
    }

    Post(customer:Customers):Observable<any>{

        let url=environment.northwindApi + this.endpoint;
        let rsta=this.http.post<Array<Customers>>(url, customer);
        console.log("rsta", rsta);

        return rsta;

    }

}
