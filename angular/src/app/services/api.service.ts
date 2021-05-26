import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private httpClient: HttpClient) { }

  getAllUser() {
    return this.httpClient.get(`${environment.apiUrl}api/Account/user`);
  }

  getFacultys() {
    return this.httpClient.get(`${environment.apiUrl}api/faculty`);
  }

  getRooms() {
    return this.httpClient.get(`${environment.apiUrl}api/room`);
  }

  getClassrooms() {
    return this.httpClient.get(`${environment.apiUrl}api/classroom`);
  }

  getSubject() {
    return this.httpClient.get(`${environment.apiUrl}api/subject`);
  }

  getSchedule() {
    return this.httpClient.get(`${environment.apiUrl}api/schedule`);
  }

}
