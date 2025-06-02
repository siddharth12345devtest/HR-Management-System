import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from 'src/app/Shared/model/employee.model';
import { Observable } from 'rxjs';
import { environment } from 'src/environment/environment';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = environment.backend.baseURL;
  private employeeUrl = this.apiUrl + "api/Employee";

  constructor(private http: HttpClient) {}

  getAllEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.employeeUrl);
  }
  
}
