import { ABMInterface } from "./ABMInterface";

export class Models_Customers implements ABMInterface<Models_Customers>{
    
    customerID: string;

    companyName: string;

    contactName: string;

    country: string;

    public Models_Customers(id :string, comapnyName: string, contactName:string, country:string){

        this.customerID=id;
        this.companyName=comapnyName,
        this.contactName=contactName,
        this.country=country
    }

    public getCustomerId():string{
        return this.customerID;
    }

    public getCompanyName():string{
        return this.companyName;
    }

    public getContactName():string{
        return this.contactName;
    }

    public  getCountry():string{
        return this.country;
    }


    GetAll(): Models_Customers[] {
        throw new Error("Method not implemented.");
    }

    GetById(id: string): Models_Customers;
    GetById(id: number): Models_Customers;
    GetById(id: any): Models_Customers {
        throw new Error("Method not implemented.");
    }

    Delete(id: string): string;
    Delete(id: number): string;
    Delete(id: any): string {
        throw new Error("Method not implemented.");
    }
    
    Insert(obj: Models_Customers): string {
        throw new Error("Method not implemented.");
    }

    Update(obj: Models_Customers): string {
        throw new Error("Method not implemented.");
    }
}