import { Component, AfterViewInit } from '@angular/core';
import { Chart } from 'chart.js/auto';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements AfterViewInit {
  ngAfterViewInit(): void {
    const ctx: any = document.getElementById('attendanceChart');
    new Chart(ctx, {
      type: 'doughnut',
      data: {
        labels: ['Present', 'Late', 'Permission', 'Absent'],
        datasets: [{
          data: [59, 21, 2, 15],
          backgroundColor: ['#0d6efd', '#ffc107', '#17a2b8', '#dc3545'],
          borderWidth: 0
        }]
      },
      options: {
        cutout: '70%',
        plugins: {
          legend: {
            display: false
          }
        }
      }
    });
  }
}
