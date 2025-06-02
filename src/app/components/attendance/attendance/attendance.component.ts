import { Component, OnInit } from '@angular/core';
import { UserAttendance } from 'src/app/Shared/model/user-attendance.model';
import { UserAttendanceService } from 'src/app/Shared/Service/user-attendance.service';


@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.css']
})
export class AttendanceComponent implements OnInit {
  attendances: UserAttendance[] = [];

  metrics = [
    { icon: '🕓', value: '8.36 / 9', trend: '⬆ 5% This Week', label: 'Total Hours Today', trendClass: 'text-success' },
    { icon: '📅', value: '10 / 40', trend: '⬆ 7% Last Week', label: 'Total Hours Week', trendClass: 'text-success' },
    { icon: '📆', value: '75 / 98', trend: '⬇ 8% Last Month', label: 'Total Hours Month', trendClass: 'text-danger' },
    { icon: '⏱', value: '16 / 28', trend: '⬇ 6% Last Month', label: 'Overtime This Month', trendClass: 'text-danger' },
  ];

  timelineBarColors = ['bg-success', 'bg-success', 'bg-warning', 'bg-success', 'bg-success', 'bg-success', 'bg-primary', 'bg-primary'];

  constructor(private attendanceService: UserAttendanceService) {}

  ngOnInit(): void {
    this.attendanceService.getAllAttendances().subscribe({
      next: (data) => this.attendances = data,
      error: (err) => console.error('Error fetching data', err)
    });
  }
}
