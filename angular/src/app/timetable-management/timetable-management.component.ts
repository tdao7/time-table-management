import { Component, OnInit } from '@angular/core';
import {ApiService} from "../services/api.service";

@Component({
  selector: 'app-timetable-management',
  templateUrl: './timetable-management.component.html',
  styleUrls: ['./timetable-management.component.css']
})
export class TimetableManagementComponent implements OnInit {

  users;
  faculties;
  classrooms;
  rooms;
  subjects;
  schedules;

  constructor(private apiServices: ApiService) { }

  ngOnInit(): void {
    this.getAllUser();
    this.getAllFaculty();
    this.getAllRoom();
    this.getAllSubject();
    this.getAllSchedule();
  }

  getAllUser() {
    this.apiServices.getAllUser().subscribe(data => {
      this.users = data;
    })
  }

  getAllFaculty() {
    this.apiServices.getFacultys().subscribe(data => {
      this.faculties = data;
    })
  }

  getAllRoom() {
    this.apiServices.getRooms().subscribe(data => {
      this.rooms = data;
    })
  }

  getAllSubject() {
    this.apiServices.getSubject().subscribe(data => {
      this.subjects = data;
    })
  }

  getAllSchedule() {
    this.apiServices.getSchedule().subscribe(data => {
      this.schedules = data;
    })
  }

}
