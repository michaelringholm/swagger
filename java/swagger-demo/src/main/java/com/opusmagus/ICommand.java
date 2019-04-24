package com.opusmagus;

public interface ICommand<I,O> {
    public O Execute(I input) throws Exception;
}