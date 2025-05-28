import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AttendanceComponent } from './components/attendance/attendance/attendance.component';
import { DashboardComponent } from './components/dashboard/dashboard/dashboard.component';
import { DepartmentComponent } from './components/department/department/department.component';
import { DesignationsComponent } from './components/designations/designations/designations.component';
import { EmployeeComponent } from './components/employee/employee/employee.component';
import { PayrollComponent } from './components/payroll/payroll/payroll.component';
import { PerformanceAppraisalComponent } from './components/performance-appraisal/performance-appraisal/performance-appraisal.component';
import { ClaimsComponent } from './components/claims/claims/claims.component';
import { BroadcastComponent } from './components/broadcast/broadcast/broadcast.component';
import { IndicatorComponent } from './components/performance-appraisal/indicator/indicator.component';
import { ReviewComponent } from './components/performance-appraisal/review/review.component';
import { AppraisalComponent } from './components/performance-appraisal/appraisal/appraisal.component';

const routes: Routes = [
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'attendance', component: AttendanceComponent },
  { path: 'department', component: DepartmentComponent },
  { path: 'designations', component: DesignationsComponent },
  { path: 'employee', component: EmployeeComponent },
  { path: 'payroll', component: PayrollComponent },
  { path: 'performance-appraisal', component: PerformanceAppraisalComponent },
  { path: 'claims', component: ClaimsComponent },
  { path: 'broadcast', component: BroadcastComponent },
  {path:'performance',
     children : [
      {path: 'indicator', component:IndicatorComponent },
      {path: 'review', component:ReviewComponent },
      {path: 'appraisal', component:AppraisalComponent},
    ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
