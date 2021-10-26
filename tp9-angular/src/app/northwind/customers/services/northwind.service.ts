import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Customers } from "../models/customers";
import { Observable, Observer, Subject } from "rxjs";
import { environment } from "src/environments/environment";
//duda

@Injectable({
    providedIn:'root'
})

export class ServiceNorthwind{

    endpoint: string='CustomerApi';
    changedCustomers:boolean=false;
    customers: Array<Customers>=[];
    

    constructor(private http:HttpClient){
    }

    delete(custId:string):Observable<any>{
        let idString:string='?custId=' + custId;
        let url=environment.northwindApi + this.endpoint + idString;
        let rsta=this.http.delete<any>(url);
        return rsta;
    }

    getAll(): Observable<Array<Customers>>{
        let url=environment.northwindApi + this.endpoint;
        return this.http.get<Array<Customers>>(url);
    }

    getById(custId:string):Observable<any>{
        let idString:string='?custId=' + custId;
        let url=environment.northwindApi + this.endpoint + idString;
        return this.http.get<any>(url);
    }

    put(customer:Customers):Observable<any>{
        let url=environment.northwindApi + this.endpoint;
        let rsta=this.http.put<Array<Customers>>(url, customer);
        return rsta;
    }

    post(customer:Customers):Observable<any>{
        let url=environment.northwindApi + this.endpoint;
        let rsta=this.http.post<Array<Customers>>(url, customer);
        return rsta;

    }

}
