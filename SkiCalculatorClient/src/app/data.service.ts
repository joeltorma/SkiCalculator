import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private REST_API_SERVER_GET_SKI_LENGTH = 'https://localhost:5001/api/CalculatorPage/GetSkiLenght/';

  constructor(private httpClient: HttpClient) { }

  sendGetRequest(height: number, age: number, style:string) {
    return this.httpClient.get(this.REST_API_SERVER_GET_SKI_LENGTH+height+'/'+age+'/'+style);
  }
}
