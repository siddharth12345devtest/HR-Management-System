import { Component } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent  {
  employees = [
    {
      id: 'Emp-001',
      name: 'Anthony Lewis',
      role: 'Finance',
      email: 'anthony@example.com',
      phone: '(123) 4567 890',
      designation: 'Finance',
      joiningDate: '12 Sep 2024',
      status: 'Active',
      image: 'https://randomuser.me/api/portraits/men/32.jpg'
    },
    {
      id: 'Emp-002',
      name: 'Brian Villalobos',
      role: 'Developer',
      email: 'brian@example.com',
      phone: '(179) 7382 829',
      designation: 'Developer',
      joiningDate: '24 Oct 2024',
      status: 'Inactive',
      image: 'https://randomuser.me/api/portraits/men/45.jpg'
    }
  ];
}