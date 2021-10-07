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

    public GetAll(): Observable<Array<Customers>>{

        let url=environment.northwindApi + this.endpoint;
        return this.http.get<Array<Customers>>(url);
    }

}
