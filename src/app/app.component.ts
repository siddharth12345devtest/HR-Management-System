import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HRMSUI';

  isSidebarCollapsed = false;
  isPayrollExpanded = false;
  isClaimsExpanded = false;
  isPerformanceExpanded = false;

  toggleSidebar() {
    this.isSidebarCollapsed = !this.isSidebarCollapsed;

    // Collapse all submenus when sidebar is collapsed
    if (this.isSidebarCollapsed) {
      this.isPayrollExpanded = false;
      this.isClaimsExpanded = false;
      this.isPerformanceExpanded = false;
    }
  }

  toggleMenu(section: string) {
    if (section === 'payroll') {
      this.isPayrollExpanded = !this.isPayrollExpanded;
    } else if (section === 'claims') {
      this.isClaimsExpanded = !this.isClaimsExpanded;
    } else if (section === 'performance') {
      this.isPerformanceExpanded = !this.isPerformanceExpanded;
    }
  }
}
