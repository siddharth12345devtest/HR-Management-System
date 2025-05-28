import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DashboardComponent } from './components/dashboard/dashboard/dashboard.component';
import { AttendanceComponent } from './components/attendance/attendance/attendance.component';
import { DepartmentComponent } from './components/department/department/department.component';
import { DesignationsComponent } from './components/designations/designations/designations.component';
import { EmployeeComponent } from './components/employee/employee/employee.component';
import { PayrollComponent } from './components/payroll/payroll/payroll.component';
import { BroadcastComponent } from './components/broadcast/broadcast/broadcast.component';
import { ClaimsComponent } from './components/claims/claims/claims.component';
import { PerformanceAppraisalComponent } from './components/performance-appraisal/performance-appraisal/performance-appraisal.component';
import { IndicatorComponent } from './components/performance-appraisal/indicator/indicator.component';
import { ReviewComponent } from './components/performance-appraisal/review/review.component';
import { AppraisalComponent } from './components/performance-appraisal/appraisal/appraisal.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    AttendanceComponent,
    DepartmentComponent,
    DesignationsComponent,
    EmployeeComponent,
    PayrollComponent,
    BroadcastComponent,
    ClaimsComponent,
    PerformanceAppraisalComponent,
    IndicatorComponent,
    ReviewComponent,
    AppraisalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,MatSidenavModule,
    MatToolbarModule,
    MatListModule,
    MatIconModule,
    MatButtonModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
