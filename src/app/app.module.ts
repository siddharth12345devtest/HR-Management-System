import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatTableModule } from '@angular/material/table';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatCardModule } from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DashboardComponent } from './components/dashboard/dashboard/dashboard.component';
import { AttendanceComponent } from './components/attendance/attendance/attendance.component';
import { DepartmentComponent } from './components/department/department/department.component';
import { DesignationsComponent } from './components/designations/designations/designations.component';
import { EmployeeComponent } from './components/employee/employee/employee.component';
import { BroadcastComponent } from './components/broadcast/broadcast/broadcast.component';
import { ClaimsComponent } from './components/claims/claims/claims.component';
import { PerformanceAppraisalComponent } from './components/performance-appraisal/performance-appraisal/performance-appraisal.component';
import { IndicatorComponent } from './components/performance-appraisal/indicator/indicator.component';
import { ReviewComponent } from './components/performance-appraisal/review/review.component';
import { AppraisalComponent } from './components/performance-appraisal/appraisal/appraisal.component';
import { EmployeeSalaryComponent } from './components/payroll/employee-salary/employee-salary.component';
import { PayslipComponent } from './components/payroll/payslip/payslip.component';
import { PayrollItemsComponent } from './components/payroll/payroll-items/payroll-items.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    AttendanceComponent,
    DepartmentComponent,
    DesignationsComponent,
    EmployeeComponent,
    BroadcastComponent,
    ClaimsComponent,
    PerformanceAppraisalComponent,
    IndicatorComponent,
    ReviewComponent,
    AppraisalComponent,
    EmployeeSalaryComponent,
    PayslipComponent,
    PayrollItemsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,MatSidenavModule,
    MatToolbarModule,
    MatListModule,
    MatIconModule,
    MatButtonModule,
    MatTableModule,
    MatCheckboxModule,
    MatSelectModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatCardModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
