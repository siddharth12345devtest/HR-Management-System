import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environment/environment';
import { UserAttendance } from '../model/user-attendance.model';

@Injectable({
  providedIn: 'root'
})
export class UserAttendanceService {
  private apiUrl = environment.backend.baseURL;
  private attendanceUrl = this.apiUrl + 'api/UserAttendance';

  constructor(private http: HttpClient) {}

  getAllAttendances(): Observable<UserAttendance[]> {
    return this.http.get<UserAttendance[]>(this.attendanceUrl);
  }
}
